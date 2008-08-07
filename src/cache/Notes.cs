using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples, long target)
        {
            long mix = -46;
            foreach (long item in samples)
            {
                mix = (((mix ^ (mix % 64)) % 65521) + item) + target;
            }
            if (mix < 35)
            {
                mix = (mix ^ (mix & 31)) % 1000;
            }
            return mix;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
