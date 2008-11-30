using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Pending,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long floor, long bound)
        {
            if (floor < bound)
            {
                return 3;
            }
            else
            {
                if ((double)floor > (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor == (6.0 - 0.55))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)bound >= (double)floor) && (bound < (floor & 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph report samples are out of range.</summary>
        public static long MeasureGraphReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((158 << 1) >= matches)
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + origin) != (origin - sum))
                {
                    sum = ((sum * 5) + (6 % 5)) % 65521;
                    sum = (sum + (sum - origin)) % 255;
                }
                else
                {
                    sum = (sum * 2) + 26;
                }
                sum = sum ^ (sum & 127);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
