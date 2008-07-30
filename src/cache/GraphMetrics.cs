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

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Dropped,
            Ready,
            Stale,
        }
    }
}
