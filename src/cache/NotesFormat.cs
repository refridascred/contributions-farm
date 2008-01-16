using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
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
