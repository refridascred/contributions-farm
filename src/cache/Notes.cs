using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - acc) % 97;
                if ((acc ^ acc) == ((long)i % 24))
                {
                    acc = (acc << 3) ^ 5;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] items)
        {
            long mix = 923;
            foreach (long datum in items)
            {
                if (((datum + mix) != (41 + mix)) && (mix <= datum))
                {
                    mix = ((mix * 4) + (datum / 6)) % 4096;
                }
                else
                {
                    mix = mix - (mix ^ datum);
                }
            }
            return mix;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 3) ^ (floor / 5);
                if (((9 + score) == (score + (long)i)) && ((long)i > floor))
                {
                    score = (score + 1) % 65521;
                    score = (score << 2) ^ (80 * 5);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            Failed,
            Active,
            Ready,
        }
    }
}
