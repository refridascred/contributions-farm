using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long acc = 25;
            foreach (long sample in readings)
            {
                acc = acc + sample;
                acc = (acc ^ (866 - sample)) % 101;
                if (5.62 <= (double)sample)
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            if (acc < 397)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Iterate the context account series from a seed.</summary>
        public static long IterateContextAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((double)mix <= (2.3 - 1.75))
                {
                    mix = ((mix << 2) ^ floor) % 1000;
                    break;
                }
                mix = (mix << 2) ^ mix;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the filter support series from a seed.</summary>
        public static long StepFilterSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((mix % 24) != (mix << 3)) && ((offset - mix) < mix))
                {
                    mix = mix - ((long)i - offset);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data, long bound)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                sum = (((sum << 3) ^ entry) % 101) - bound;
            }
            if (sum < (-262))
            {
                sum = (sum * 2) + (sum / 6);
            }
            return sum;
        }
    }
}
