using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (offset * 0.2))
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (offset - offset)) - (double)(long)i;
            }
            return rate + (rate - ratio);
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
