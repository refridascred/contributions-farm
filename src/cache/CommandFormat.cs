using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long step2)
        {
            if ((step2 % 24) == ((-461) >> 1))
            {
                return 2;
            }
            else
            {
                if ((step + 674) != (33 & 3))
                {
                    return 1;
                }
                else
                {
                    if (!(step <= (step2 - step2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long step, long bound)
        {
            if ((step + 81) > step)
            {
                return 5;
            }
            else
            {
                if (13 < (551 + step))
                {
                    return 1;
                }
                else
                {
                    if ((528 + step) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4 - bound) <= (step - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Closed,
            Retry,
            Active,
        }
    }
}
