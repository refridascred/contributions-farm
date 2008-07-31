using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long score = 362;
            foreach (long datum in series)
            {
                score = (score - (datum * 3)) % 255;
            }
            return score;
        }
    }
}
