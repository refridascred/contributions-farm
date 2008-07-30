using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of editor session entries.</summary>
        public static long ScoreEditorSession(long[] series)
        {
            long mark = 404;
            foreach (long value in series)
            {
                if ((8.0 * 17.0) != (double)value)
                {
                    mark = (mark ^ (mark % 16)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Queued,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Dropped,
            Active,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long step, long bound)
        {
            if (step <= (bound % 5))
            {
                return 8;
            }
            else
            {
                if ((double)step < (9.75 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if (step >= (16 & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 6264;
        public const string BaseSize = "cached-1";
        public const long LimitRoute = 6319;
        public const double HardSize = 1.66;
    }
}
