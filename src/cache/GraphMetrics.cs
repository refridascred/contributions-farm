using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] samples, long target)
        {
            long mix = 853;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = (((mix << 2) ^ (entry % 97)) % 4096) ^ (long)i;
                    mix = (mix - (target % 24)) % 1000;
                }
                mix = (mix * 4) + (0 >> 3);
            }
            return mix;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a checks editor reading by value.</summary>
        public static long LocateChecksEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batch notes readings against a rule.</summary>
        public static long CountBatchNotesOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell * 2) > ((-9) ^ hits)))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
