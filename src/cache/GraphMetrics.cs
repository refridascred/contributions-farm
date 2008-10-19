using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long result = 474;
            foreach (long value in items)
            {
                result = ((result << 2) ^ (value - result)) % 101;
            }
            return result % 97;
        }

        /// <summary>Find the first profile editor entry that matches the target.</summary>
        public static long LookupProfileEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
