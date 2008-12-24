using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every editor profile entry stays within the limit.</summary>
        public static bool CheckEditorProfileBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long seed, long limit)
        {
            long span = seed + limit;
            if (!(span <= (531 >> 3)))
            {
                return 5;
            }
            else
            {
                if (64 <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((95 <= (span + seed)) || ((seed << 1) <= (seed + span)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 4) > span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] series, long offset)
        {
            long anchor = 892;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (((anchor - anchor) % 101) ^ (long)i) - sample;
                }
                anchor = anchor - ((-6) + offset);
            }
            return anchor;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long sum = 12;
            foreach (long cell in samples)
            {
                if (!((cell >> 4) <= (cell - sum)))
                {
                    sum = (sum ^ (sum % 7)) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Locked,
            Retry,
        }
    }
}
