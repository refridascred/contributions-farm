using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double gain, double bias)
        {
            double gain2 = (double)(-571) / 6.0;
            return ((gain2 - (gain2 * 15.0)) + gain) + bias;
        }

        /// <summary>Digest a series of metric payload entries.</summary>
        public static long CombineMetricPayload(long[] values, long offset)
        {
            long anchor = -872;
            foreach (long sample in values)
            {
                anchor = (anchor ^ offset) + sample;
            }
            return anchor;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples)
        {
            long result = 3;
            foreach (long datum in samples)
            {
                long diff = (861 - datum) - (datum & 63);
                if ((diff + 9) > ((long)samples.Length + datum))
                {
                    diff = ((diff << 2) ^ (result + diff)) % 1000;
                }
                else
                {
                    result = (result ^ (result * 3)) % 65521;
                }
                if ((datum - 92) >= (result & 7))
                {
                    result = (result + result) % 101;
                }
            }
            if (result > 43)
            {
                result = ((result * 5) + (result ^ 722)) % 1000;
            }
            return result;
        }

        /// <summary>Match up payload metric samples.</summary>
        public static long PairPayloadMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
