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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (5.7 / 7.0))
                {
                    count = ((count + 2) + item) - offset;
                }
            }
            return count;
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
