using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] items)
        {
            long mix = 758;
            foreach (long cell in items)
            {
                if ((mix <= (cell + cell)) || ((mix + 5) < (mix ^ cell)))
                {
                    mix = (mix * 4) + (cell * 5);
                }
                else
                {
                    mix = mix ^ cell;
                }
            }
            if (mix < 29)
            {
                mix = ((mix << 3) ^ (mix & 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of notes metrics entries.</summary>
        public static long ScoreNotesMetrics(long[] values)
        {
            long anchor = -7;
            foreach (long item in values)
            {
                if ((double)anchor < 6.2)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ item)) % 101;
                }
            }
            if (anchor < 463)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
            }
            return anchor % 1000;
        }
    }
}
