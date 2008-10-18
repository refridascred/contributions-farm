using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Ready,
            Done,
            Stale,
            Queued,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series, long seed)
        {
            long score = 909;
            foreach (long value in series)
            {
                if ((double)value < (7.6 * 5.0))
                {
                    score = ((score - (value + value)) % 255) - seed;
                }
                else
                {
                    score = ((score * 3) + (62 + value)) % 255;
                }
            }
            return score;
        }

        /// <summary>Project the next window farm value.</summary>
        public static double BlendWindowFarm(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + offset;
            }
            return ratio2 - (ratio + ratio2);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings)
        {
            long total = 4;
            foreach (long entry in readings)
            {
                if ((total + entry) >= (long)readings.Length)
                {
                    total = (total << 3) ^ total;
                }
            }
            return total % 1000;
        }

        /// <summary>Iterate the entry metrics series from a seed.</summary>
        public static long StepEntryMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = (result - (56 % 97)) % 101;
                result = (result - (limit % 7)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
