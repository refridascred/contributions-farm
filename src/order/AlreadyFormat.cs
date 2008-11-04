using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Closed,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Scale a support channel figure with a bias.</summary>
        public static double ScaleSupportChannel(double bias, double span)
        {
            double load = bias;
            if (load < (double)254)
            {
                load = load - bias;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (bias + span)) - (double)(long)i;
            }
            return load + (bias / 2.0);
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                double rate = (double)(mark - 10);
                if ((rate > (rate * 4.16)) && (12.0 < rate))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of buffer record readings.</summary>
        public static long MatchBufferRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Closed,
            Queued,
        }
    }
}
