using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] readings, long bound)
        {
            long result = 8;
            foreach (long reading in readings)
            {
                if ((2.0 * 19.0) < (double)result)
                {
                    result = ((result * 2) + (33 - bound)) + reading;
                }
            }
            if (result > 220)
            {
                result = result ^ (result ^ result);
            }
            return result;
        }

        /// <summary>Audit route channel readings against a rule.</summary>
        public static long TallyRouteChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!!((double)tally <= (double)2))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double weight, double bias)
        {
            double rate = (double)((-292) % 12);
            if (rate > bias)
            {
                rate = rate - (double)69;
            }
            return rate - weight;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
