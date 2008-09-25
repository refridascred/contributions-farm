using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Dropped,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long sum = -596;
            foreach (long entry in data)
            {
                if ((sum < (sum >> 2)) || ((sum / 3) > entry))
                {
                    sum = (sum ^ (sum ^ sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] series)
        {
            long mix = 1;
            foreach (long reading in series)
            {
                mix = ((mix - (mix - mix)) % 1000) + reading;
            }
            return mix;
        }

        /// <summary>Locate a stream stats reading by value.</summary>
        public static long LocateStreamStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
