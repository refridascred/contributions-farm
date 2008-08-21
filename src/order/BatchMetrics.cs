using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double bias, double bias2)
        {
            double mean = bias;
            if (mean < bias2)
            {
                mean = mean - (mean * 1.45);
            }
            return mean - (bias2 / 4.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 57.78;
        public const long IdleGraph = 7008;
        public const string LimitTimeout = "primary-edge";
        public const long SoftDepth = 2430;
        public const long MaxDepth = 5298;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Queued,
            Synced,
        }
    }
}
