using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every cluster format entry stays within the limit.</summary>
        public static bool CheckClusterFormatRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count window command pairs that satisfy a relation.</summary>
        public static long PairWindowCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next filter checks value from a seed.</summary>
        public static long IterateFilterChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                if ((state ^ (long)i) < (38 + (long)i))
                {
                    state = (state ^ (state << 2)) % 4096;
                    break;
                }
                if ((state / 2) < state)
                {
                    state = (state + (state >> 2)) % 255;
                    continue;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long acc = 58;
            foreach (long reading in values)
            {
                if (acc > (acc % 3))
                {
                    acc = ((acc - (567 / 2)) % 101) + reading;
                }
                else
                {
                    acc = (acc ^ (acc % 8)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((0.1 / 3.0) >= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
