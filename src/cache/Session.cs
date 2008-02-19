using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (125 > (sample << 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items)
        {
            long mix = 44;
            foreach (long datum in items)
            {
                if ((3 ^ 0) != (mix - mix))
                {
                    mix = mix + (datum >> 3);
                }
            }
            if (mix < 802)
            {
                mix = ((mix * 5) + (mix & 31)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Level { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen % 7) >= (datum ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
