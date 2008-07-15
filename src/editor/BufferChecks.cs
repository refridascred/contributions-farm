using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((step <= (2 + 83)) || !(entry < (step + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of metrics stream readings.</summary>
        public static long PairMetricsStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series, long target)
        {
            long state = 699;
            foreach (long reading in series)
            {
                if ((reading > (77 ^ target)) || (state >= (7 + reading)))
                {
                    state = ((state << 3) ^ (98 << 1)) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ (target - reading)) % 4096;
                }
            }
            if (state > 651)
            {
                state = (state * 2) + target;
            }
            return state;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading < (tally - tally))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
