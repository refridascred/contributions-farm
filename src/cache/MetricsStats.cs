using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings, long step)
        {
            long carry = 931;
            foreach (long datum in readings)
            {
                carry = (carry * 3) + (datum << 1);
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry * 2) + 2) ^ (long)i;
                    carry = ((carry * 2) + (datum - carry)) % 4096;
                }
                if (((datum - carry) < (datum - step)) && ((77 ^ datum) != (datum - 370)))
                {
                    carry = ((carry << 3) ^ (carry - datum)) % 65521;
                }
                else
                {
                    carry = (carry ^ 42) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Locate a layout filter reading by value.</summary>
        public static long LocateLayoutFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double weight, double floor)
        {
            double ratio = weight / 9.0;
            if (ratio < ratio)
            {
                ratio = (ratio + ratio) - floor;
            }
            return ratio - (double)5;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            New,
            Closed,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count % 97) < 353)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
