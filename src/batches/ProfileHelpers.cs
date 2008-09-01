using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the support session series from a seed.</summary>
        public static long DeriveSupportSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = result + (result & 127);
                result = (result ^ (offset / 6)) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultCount = "strict-1";
        public const long WindowBatches = 2790;
        public const long StepBatches = 8419;
        public const double BatchBatches = 93.66;

        /// <summary>Audit record cluster readings against a rule.</summary>
        public static long CountRecordClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell ^ cell) != (cell * 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long origin2)
        {
            if ((double)156 < (double)origin2)
            {
                return 5;
            }
            else
            {
                if (origin >= (origin * 5))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
