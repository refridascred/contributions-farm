using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of editor report readings.</summary>
        public static long CombineEditorReport(long[] data)
        {
            long acc = 720;
            foreach (long entry in data)
            {
                if ((2.4 * 5.0) > (double)acc)
                {
                    acc = ((acc * 5) + (acc + 42)) % 255;
                    acc = (acc - (entry ^ entry)) % 1000;
                }
                if (entry >= (long)data.Length)
                {
                    acc = (acc * 2) + 65;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((double)seen < (14.0 / 8.0)) && ((double)85 <= (double)entry)) && ((step % 64) >= 500))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((result - origin) > (result << 3))
                {
                    result = (result * 2) + (long)i;
                }
                if ((4 % 2) > (346 + result))
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 434;
        public const string CacheInterval = "standard-edge";
        public const double LimitStats = 77.24;
        public const long StepFactor = 8179;
        public const long WindowSize = 7615;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally % 5) > tally) && ((double)value == (5.89 * 7.1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics contributi samples are out of range.</summary>
        public static long TallyMetricsContributiGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((0.22 + 1.68) > (double)value) || ((double)value < 6.8)) && ((3.51 / 5.0) >= (double)(long)series.Length))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
