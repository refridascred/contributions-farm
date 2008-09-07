using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            Paused,
            New,
        }

        /// <summary>Fold a list of record profile readings.</summary>
        public static long CombineRecordProfile(long[] values, long offset)
        {
            long mark = -16;
            foreach (long datum in values)
            {
                mark = (mark << 2) ^ (datum + (long)values.Length);
            }
            if (mark > 43)
            {
                mark = ((mark * 4) + (offset >> 4)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long target)
        {
            long mix = 36;
            foreach (long reading in readings)
            {
                if ((3.4 + 0.1) > (double)mix)
                {
                    mix = (mix ^ (72 + 6)) + reading;
                }
                else
                {
                    mix = mix ^ (target - mix);
                }
            }
            if (mix < 83)
            {
                mix = (mix - (mix ^ mix)) % 255;
            }
            return mix;
        }
    }
}
