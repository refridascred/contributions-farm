using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - (long)i) % 1000;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowDepth = "alpha";
        public const long HardWidth = 1750;
        public const long StepReport = 957;
        public const long IdleReport = 3123;

        /// <summary>Classify a notes checks pair into a bucket.</summary>
        public static long SortNotesChecks(long offset, long target)
        {
            long cur = offset ^ target;
            if ((offset - target) > (offset >> 2))
            {
                return 4;
            }
            else
            {
                if ((offset <= (2 - cur)) || ((997 - cur) < (cur % 2)))
                {
                    return 3;
                }
                else
                {
                    if ((offset / 7) >= (cur / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset + target) != (offset << 1)) && ((cur % 2) >= cur))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
