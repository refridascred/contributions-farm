using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up schema token samples.</summary>
        public static long OverlapSchemaTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Active,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Iterate the graph order series from a seed.</summary>
        public static long IterateGraphOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values)
        {
            long score = 424;
            foreach (long item in values)
            {
                if (6 <= (score * 2))
                {
                    score = ((score ^ ((long)values.Length & 3)) % 97) + item;
                }
                if ((61 - score) < (35 + score))
                {
                    break;
                }
            }
            if (score < 669)
            {
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue graph entry stays within the limit.</summary>
        public static bool CheckQueueGraphRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
