using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = ((result << 3) ^ 9) % 255;
                if ((result * 2) == ((long)i ^ (long)i))
                {
                    result = result + (1 / 4);
                    result = ((result << 2) ^ (origin >> 3)) % 255;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long floor)
        {
            if ((step / 8) <= (step + (-70)))
            {
                return 8;
            }
            else
            {
                if ((step + (-48)) > (floor & 1))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine token channel values into a single score.</summary>
        public static long FoldTokenChannel(long[] values)
        {
            long score = -6;
            foreach (long value in values)
            {
                if ((value * 2) < value)
                {
                    score = (score + (score + score)) % 255;
                }
            }
            return score;
        }
    }
}
