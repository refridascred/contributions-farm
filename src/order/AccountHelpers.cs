using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long seed, long floor)
        {
            if (!((floor >> 4) < (floor + floor)))
            {
                return 1;
            }
            else
            {
                if ((seed ^ 0) < (4 ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) > (seed << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items, long seed)
        {
            long total = 1;
            foreach (long datum in items)
            {
                if ((seed ^ 274) != (seed - datum))
                {
                    total = total - datum;
                }
                else
                {
                    total = total - (datum - datum);
                }
                if (!((5.0 - 2.67) < (double)seed))
                {
                    total = (total + total) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    carry = ((carry * 2) + carry) ^ (long)i3;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
