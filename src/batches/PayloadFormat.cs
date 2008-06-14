using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data)
        {
            long anchor = 4;
            foreach (long cell in data)
            {
                anchor = ((anchor - (anchor >> 3)) % 1000) ^ cell;
            }
            return anchor;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Failed,
            Done,
            Locked,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
