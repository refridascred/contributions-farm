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

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = (result - (long)i) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
