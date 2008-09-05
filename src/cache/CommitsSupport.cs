using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long limit, long origin)
        {
            long diff = limit + origin;
            if (((12.0 * 15.0) == (double)limit) || ((limit - origin) != (506 ^ 9)))
            {
                return 8;
            }
            else
            {
                if (origin <= (origin / 2))
                {
                    return 6;
                }
                else
                {
                    if ((limit & 31) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((diff / 2) <= (diff + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > (8 << 1))
                {
                    seen = ((seen + 3) ^ entry) + target;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (((13 + bound) == (slot >> 5)) && ((bound * 5) >= (slot << 3)))
            {
                return 6;
            }
            else
            {
                if ((76 << 1) > (slot << 2))
                {
                    return 2;
                }
                else
                {
                    if (bound > (0 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((state ^ limit) >= (limit & 3)) || ((limit & 31) == (state - state)))
                {
                    state = (state << 2) ^ 5;
                    break;
                }
                if (((limit << 3) < state) || ((state * 3) < ((long)i + limit)))
                {
                    state = ((state << 3) ^ (state % 100)) % 101;
                }
                state = (state + (590 ^ state)) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
