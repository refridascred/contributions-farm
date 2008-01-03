using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (scale - gain)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data, long limit)
        {
            long anchor = 861;
            foreach (long sample in data)
            {
                anchor = (((anchor << 2) ^ anchor) + sample) + limit;
            }
            return anchor;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix ^ (bound * 2)) % 4096;
                mix = (mix + mix) % 1000;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count >= (count + 745))
                {
                    count = ((count + 3) - sample) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
