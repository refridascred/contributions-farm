using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8983;
        public const double MinInterval = 33.57;
        public const long RetryFactor = 7897;
        public const long HardDepth = 5733;
        public const string DefaultReport = "legacy-edge";

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftCommand = "alpha";
        public const long RetryTimeout = 9539;
        public const long WindowCommand = 4968;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((bound + offset) > edge)
            {
                return 2;
            }
            else
            {
                if ((edge - offset) <= (3 + bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound - 9) != (edge - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(bound > 55))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
