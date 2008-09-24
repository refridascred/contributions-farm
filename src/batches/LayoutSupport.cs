using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long target, long target2)
        {
            long bound = target - target2;
            if (1 > target2)
            {
                return 8;
            }
            else
            {
                if ((double)target2 >= (3.7 - 8.8))
                {
                    return 3;
                }
                else
                {
                    if (target2 > (bound + 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target2 ^ bound) != (0 ^ target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstWidth = 957;
        public const double BaseEntry = 46.8;
        public const string MaxEntry = "standard-1";
        public const string IdleBudget = "cached-1";

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = state - (offset - offset);
                if (((112 * 3) < (offset % 24)) || ((offset << 2) != (offset ^ state)))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
