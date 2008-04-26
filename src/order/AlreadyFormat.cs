using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if (((result >> 5) != (long)i) && ((step * 5) >= (step >> 3)))
                {
                    result = (result * 5) + (long)i;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many cache buffer samples are out of range.</summary>
        public static long MeasureCacheBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((((value << 1) < (matches + value)) && ((matches - matches) > value)) || ((matches < (matches - 3)) && (value >= matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] series)
        {
            long anchor = 5;
            foreach (long reading in series)
            {
                if ((3.0 + 3.44) > (double)reading)
                {
                    anchor = anchor - (reading * 2);
                }
            }
            if (anchor < (-218))
            {
                anchor = (anchor + (5 & 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((4.0 - 5.0) != (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings)
        {
            long result = 55;
            foreach (long cell in readings)
            {
                result = (((result * 4) + (result % 97)) % 1000) + cell;
            }
            return result;
        }
    }
}
