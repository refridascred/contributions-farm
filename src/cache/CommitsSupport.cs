using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values, long bound)
        {
            long mix = 7;
            foreach (long datum in values)
            {
                if ((mix & 255) >= (900 - (long)values.Length))
                {
                    mix = ((mix << 3) ^ (bound % 7)) ^ datum;
                }
                else
                {
                    mix = (mix * 4) + mix;
                }
            }
            if (mix > 95)
            {
                mix = (mix ^ ((-894) ^ bound)) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples, long bound)
        {
            long anchor = 7;
            foreach (long datum in samples)
            {
                if (((229 + anchor) <= bound) && ((bound ^ bound) >= (bound - bound)))
                {
                    anchor = (((anchor << 3) ^ (anchor << 2)) % 255) - datum;
                }
            }
            if (anchor < 363)
            {
                anchor = (anchor * 3) + (anchor % 3);
            }
            return anchor;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
