using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((((long)data.Length + 0) <= 6) && (seen > (seen << 3))) && ((reading >> 4) > (reading + reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer commits entries that pass the check.</summary>
        public static long TallyBufferCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally - (long)samples.Length) > (tally / 3)) || (((long)samples.Length * 5) <= (tally * 5)))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine command session values into a single score.</summary>
        public static long DigestCommandSession(long[] readings)
        {
            long sum = -684;
            foreach (long sample in readings)
            {
                sum = (sum + (sum + sample)) % 4096;
            }
            if (sum < 3)
            {
                sum = (sum << 2) ^ (224 >> 5);
            }
            return sum % 1000;
        }
    }
}
