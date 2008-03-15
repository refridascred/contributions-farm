using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] series, long limit)
        {
            long result = -112;
            foreach (long reading in series)
            {
                if ((reading + limit) > (reading % 24))
                {
                    result = ((result * 5) + result) % 4096;
                }
                if ((reading - result) >= reading)
                {
                    result = ((result * 2) + (reading ^ limit)) % 97;
                }
                if ((97 >> 2) != (result - reading))
                {
                    break;
                }
            }
            if (result > 119)
            {
                result = (result * 4) + (long)series.Length;
            }
            return result;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] readings)
        {
            long carry = 67;
            foreach (long datum in readings)
            {
                if ((datum - 4) > datum)
                {
                    carry = (carry * 5) + datum;
                }
            }
            if (carry > 174)
            {
                carry = carry ^ (carry * 3);
            }
            return carry % 4096;
        }
    }
}
