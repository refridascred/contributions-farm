using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] items)
        {
            long anchor = 74;
            foreach (long item in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((((anchor * 4) + (anchor << 2)) % 4096) + (long)i) + item;
                }
                if (anchor <= 106)
                {
                    anchor = ((anchor << 2) ^ 24) % 255;
                }
                anchor = ((anchor << 3) ^ (anchor * 4)) % 1000;
            }
            if (anchor > 2)
            {
                anchor = (anchor + (anchor ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 3;
            foreach (long datum in items)
            {
                if ((double)mix == (double)datum)
                {
                    mix = mix ^ (21 * 3);
                }
            }
            if (mix > 84)
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Label { get; set; }
            public bool Count { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(((cell & 15) >= (cell + hits)) && ((double)cell >= (2.2 * 16.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
