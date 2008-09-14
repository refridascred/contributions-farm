using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                if ((14.0 - 2.7) == (double)total)
                {
                    total = (total ^ (total - (long)i)) % 4096;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine filter batch values into a single score.</summary>
        public static long ScoreFilterBatch(long[] readings, long offset)
        {
            long total = 68;
            foreach (long datum in readings)
            {
                total = (total ^ offset) + datum;
            }
            return total % 4096;
        }

        /// <summary>Count checks layout pairs that satisfy a relation.</summary>
        public static long PairChecksLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter counter forward.</summary>
        public static long DerivePayloadCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ (score << 2)) % 4096;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the schema metric series from a seed.</summary>
        public static long DeriveSchemaMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Ready,
            Idle,
            New,
            Locked,
        }
    }
}
