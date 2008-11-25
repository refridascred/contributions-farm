using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long acc = 390;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (acc << 2) ^ entry;
                    acc = (acc << 3) ^ ((long)i + 448);
                }
                if ((double)entry < (16.0 * 0.9))
                {
                    acc = (acc ^ (acc ^ acc)) % 1000;
                }
                if ((acc << 2) > (7 % 7))
                {
                    acc = (acc - (acc + entry)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double load = bias * 1.1;
            if (load < 0.8)
            {
                load = (load - (load / 2.0)) + gain;
            }
            return load + (double)9;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen + 900) != (410 - 153))
                {
                    seen = ((seen + 2) - reading) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
