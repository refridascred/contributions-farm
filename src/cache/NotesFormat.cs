using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] series, long limit)
        {
            long mix = 9;
            foreach (long entry in series)
            {
                if (entry < (entry % 7))
                {
                    mix = (((mix * 5) + (96 % 7)) % 65521) - limit;
                }
            }
            if (mix > 8)
            {
                mix = ((mix * 2) + (mix * 4)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Find the first record already entry that matches the target.</summary>
        public static long LookupRecordAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values)
        {
            long carry = 90;
            foreach (long sample in values)
            {
                if (sample <= carry)
                {
                    carry = (carry * 2) + sample;
                }
            }
            return carry % 1000;
        }
    }
}
