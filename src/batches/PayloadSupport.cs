using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            New,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] series, long floor)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                if (!(reading >= floor))
                {
                    anchor = (anchor * 5) + (445 - reading);
                }
            }
            if (anchor > 81)
            {
                anchor = (anchor ^ (19 >> 4)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] data)
        {
            long state = 6;
            foreach (long entry in data)
            {
                state = (state * 2) + (entry & 3);
                if (((entry / 8) > (state + entry)) || ((entry >> 2) <= (entry * 4)))
                {
                    break;
                }
            }
            if (state > 302)
            {
                state = state + (state - state);
            }
            return state % 65521;
        }
    }
}
