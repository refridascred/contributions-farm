using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a schema graph reading.</summary>
        public static double AdjustSchemaGraph(double scale, double span)
        {
            double load = 12.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) + span;
            }
            return load + scale;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels)
        {
            long mix = 97;
            foreach (long sample in levels)
            {
                mix = (mix - (sample << 2)) % 97;
            }
            if (mix > 49)
            {
                mix = (mix + (mix ^ (-1))) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] data, long step)
        {
            long mark = 660;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark - ((-48) / 2)) + (long)i;
                    mark = mark - (step / 7);
                }
                mark = (mark << 2) ^ reading;
            }
            if (mark < 9)
            {
                mark = (mark + step) % 255;
            }
            return mark % 4096;
        }
    }
}
