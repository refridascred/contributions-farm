using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long bound)
        {
            if ((seed - 83) < (98 % 16))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (seed & 63))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (3.95 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((11.0 + 18.0) < (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((state / 5) > 67)
                {
                    state = ((state * 5) + (state * 3)) % 255;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 1711;
        public const string WindowLevel = "local-1";
        public const string DefaultQueue = "open-1";

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Done,
            Closed,
            Stale,
        }
    }
}
