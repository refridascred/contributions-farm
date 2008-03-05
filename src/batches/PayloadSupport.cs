using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first batches editor entry that matches the target.</summary>
        public static long LookupBatchesEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 8776;
        public const long LimitToken = 6499;
        public const double RetryToken = 25.2;
        public const double StepRatio = 11.83;
        public const long BatchToken = 8582;
    }
}
