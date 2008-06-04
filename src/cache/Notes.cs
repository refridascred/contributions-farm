using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((4 >= (limit - limit)) && ((reading % 2) <= limit))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] samples)
        {
            long total = 27;
            foreach (long sample in samples)
            {
                if ((sample & 7) > (sample ^ total))
                {
                    total = (total - sample) % 255;
                }
                else
                {
                    total = (total ^ (sample - (long)samples.Length)) % 97;
                    total = total + (total & 15);
                }
                total = total + sample;
                if ((total + 868) >= (total ^ sample))
                {
                    total = (total + (sample + sample)) % 255;
                }
                else
                {
                    total = (total ^ (sample << 2)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Fold a list of route batches readings.</summary>
        public static long ScoreRouteBatches(long[] samples)
        {
            long result = 27;
            foreach (long item in samples)
            {
                if ((6.32 + 4.97) >= (double)result)
                {
                    result = ((result << 2) ^ (item << 3)) % 255;
                }
            }
            if (result > 749)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Roll a layout batches counter forward.</summary>
        public static long DeriveLayoutBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i == (anchor << 1))
                {
                    anchor = (anchor * 3) + (anchor & 7);
                    anchor = (anchor << 3) ^ (long)i;
                }
                else
                {
                    anchor = anchor + anchor;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor ^ (anchor >> 5)) % 1000) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
