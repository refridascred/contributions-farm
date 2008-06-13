using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit batch githubfarm readings against a rule.</summary>
        public static long MeasureBatchGithubfarmHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count >> 1) >= (reading + count))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Count the record metrics entries that pass the check.</summary>
        public static long MeasureRecordMetricsHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + tally) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long bound)
        {
            long total = -112;
            foreach (long datum in series)
            {
                total = ((total * 3) + total) % 4096;
                if ((total + bound) <= (bound - total))
                {
                    total = total + (total >> 4);
                }
                else
                {
                    total = (total ^ 8) % 97;
                }
                if (((datum >> 2) <= (64 - total)) && (bound <= (datum << 2)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Failed,
            New,
            Done,
            Ready,
        }
    }
}
