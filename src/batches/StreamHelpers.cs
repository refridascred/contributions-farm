using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data, long target)
        {
            long mix = 5;
            foreach (long item in data)
            {
                if ((((long)data.Length ^ mix) > (target << 1)) || ((5.2 - 15.0) == (double)target))
                {
                    mix = ((mix * 4) + (79 / 9)) - item;
                }
            }
            return mix;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = score ^ (seed & 31);
                score = (score << 2) ^ seed;
                if (((double)score != (double)11) || ((score + (long)i) < (seed - 27)))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
