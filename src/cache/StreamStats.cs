using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up checks entry samples.</summary>
        public static long CompareChecksEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series, long limit)
        {
            long state = 96;
            foreach (long reading in series)
            {
                if ((reading + state) > 90)
                {
                    state = state ^ (state & 127);
                }
                if ((limit - limit) < 7)
                {
                    state = (state - (limit & 255)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ reading) % 97;
                }
            }
            if (state > 0)
            {
                state = (state ^ (limit + limit)) % 255;
            }
            return state;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((offset << 1) != (9 % 5)) && ((28 & 127) > entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
