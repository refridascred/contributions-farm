using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double scale = span;
            if (scale >= scale)
            {
                scale = scale + (scale - scale);
            }
            else
            {
                scale = scale + weight;
            }
            return scale - (scale + span);
        }

        /// <summary>Audit cluster schema readings against a rule.</summary>
        public static long AuditClusterSchemaGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((52 >> 5) >= (hits / 6)) || ((7.4 / 9.0) < (double)entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            Queued,
            Synced,
            Draft,
            Dropped,
        }
    }
}
