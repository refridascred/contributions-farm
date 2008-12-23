using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank buffer cluster input into a small class.</summary>
        public static long GradeBufferCluster(long origin, long seed)
        {
            long lane = origin + seed;
            if ((origin - lane) < origin)
            {
                return 6;
            }
            else
            {
                if ((450 + seed) < origin)
                {
                    return 5;
                }
                else
                {
                    if (((origin + 3) <= (seed - seed)) && ((6 / 5) >= origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next buffer entry value from a seed.</summary>
        public static long DeriveBufferEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank profile metrics input into a small class.</summary>
        public static long GradeProfileMetrics(long bound, long bound2)
        {
            if (!((double)bound2 != (double)3))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) >= (bound2 / 7))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound <= (5.0 + 8.85)) || ((bound2 + bound) > (bound2 << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)bound == (double)bound2) && ((bound2 ^ bound) > bound2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
