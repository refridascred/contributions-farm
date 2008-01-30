using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every graph tools entry stays within the limit.</summary>
        public static bool CheckGraphToolsLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((634 / 8) > (sample + 8)) && ((4.6 * 1.27) != (double)sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine editor entry values into a single score.</summary>
        public static long DigestEditorEntry(long[] items)
        {
            long result = 241;
            foreach (long datum in items)
            {
                result = (result + (datum / 6)) % 101;
            }
            if (result < 64)
            {
                result = result ^ (result + result);
            }
            return result % 65521;
        }

        /// <summary>Digest a series of stream payload entries.</summary>
        public static long WeighStreamPayload(long[] samples)
        {
            long anchor = 206;
            foreach (long entry in samples)
            {
                if (anchor > (anchor ^ anchor))
                {
                    anchor = (anchor ^ (62 + anchor)) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many metrics batch samples are out of range.</summary>
        public static long AuditMetricsBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches * 5) <= ((-8) / 9))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
