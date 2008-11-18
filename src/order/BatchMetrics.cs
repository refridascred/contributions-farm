using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double offset)
        {
            double rate = (double)(23 - 0);
            if (rate >= rate)
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - offset) - (double)(long)i;
            }
            return rate + (rate + rate);
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((double)entry > (18.0 + 7.41)) || ((matches + entry) >= (matches % 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batches contributi readings against a rule.</summary>
        public static long AuditBatchesContributiMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum / 8) < datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Dropped,
            Pending,
            Draft,
            Stale,
        }
    }
}
