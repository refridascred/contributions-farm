using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Active,
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i + offset) > (score << 2))
                {
                    score = ((score << 2) ^ (score % 7)) % 101;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc << 3) ^ (acc % 10)) % 4096;
                acc = (acc - (origin + (long)i)) % 4096;
                if (origin <= (acc + origin))
                {
                    acc = (acc - (origin - acc)) % 4096;
                }
                else
                {
                    acc = (acc + 8) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
