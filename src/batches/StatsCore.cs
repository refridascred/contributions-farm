using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings)
        {
            long score = 205;
            foreach (long sample in readings)
            {
                if ((score - sample) == (sample * 3))
                {
                    score = (score << 2) ^ (sample / 4);
                }
            }
            if (score > 232)
            {
                score = ((score << 2) ^ (score / 3)) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum < 16)
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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double bias = (double)(8 >> 3);
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias - gain)) + (double)(long)i;
            }
            return bias - (span + span);
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Idle,
            Closed,
        }
    }
}
