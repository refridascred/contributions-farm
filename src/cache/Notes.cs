using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] samples)
        {
            long carry = 385;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ 5) % 1000;
                if (((carry + datum) >= (carry / 4)) || (datum < (788 >> 3)))
                {
                    carry = (carry - datum) % 65521;
                }
            }
            if (carry < 555)
            {
                carry = (carry ^ (carry * 3)) % 97;
            }
            return carry;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long bound)
        {
            long anchor = 4;
            foreach (long value in data)
            {
                anchor = ((anchor + (anchor * 2)) % 1000) ^ value;
                if ((637 & 7) <= (anchor >> 1))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
            }
            if (anchor < (-7))
            {
                anchor = (anchor << 2) ^ (bound + bound);
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits << 2) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
