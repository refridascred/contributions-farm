using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Dropped,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Derive the next farm notes value from a seed.</summary>
        public static long SeriesFarmNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples)
        {
            long acc = 7;
            foreach (long reading in samples)
            {
                if ((8 + reading) < acc)
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc < (-41))
            {
                acc = ((acc * 2) + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "primary";
        public const long LimitSize = 3096;
        public const string RetrySize = "strict";
        public const long SoftSpan = 1203;
    }
}
