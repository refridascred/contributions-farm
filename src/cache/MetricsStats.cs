using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a format context sample.</summary>
        public static long LookupFormatContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < 3.4)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] samples, long seed)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                result = result ^ (985 ^ reading);
                result = (result << 2) ^ (reading - (-6));
                if ((0 / 2) > reading)
                {
                    result = ((result * 3) + (11 + 70)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ seed) % 255;
                }
            }
            if (result > 38)
            {
                result = ((result * 3) + (0 + result)) % 101;
            }
            return result;
        }
    }
}
