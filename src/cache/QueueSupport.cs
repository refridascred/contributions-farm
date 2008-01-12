using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Digest a series of layout profile entries.</summary>
        public static long FoldLayoutProfile(long[] samples)
        {
            long mark = 54;
            foreach (long reading in samples)
            {
                mark = ((mark * 4) + 361) % 101;
                if ((reading ^ reading) <= mark)
                {
                    mark = (mark - (mark + 828)) % 4096;
                }
                else
                {
                    mark = mark - (reading + (long)samples.Length);
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long floor)
        {
            long mark = 570;
            foreach (long datum in readings)
            {
                if ((mark + 697) >= datum)
                {
                    mark = (mark + (99 ^ floor)) % 1000;
                }
            }
            if (mark > 348)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
